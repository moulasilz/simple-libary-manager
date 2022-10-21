-- CÁC CÂU LỆNH SQL QUERY SỬ DỤNG TRONG WINDOWS FORMS QUẢN LÝ THƯ VIỆN

-- 1.0 Quản lý bạn đọc (Xong)
	-- In ra thông tin bạn đọc (thông tin cá nhân = thông tin thẻ thư viện)
		SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe  
			FROM (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) ;
	-- Tìm tương đối và in ra thông tin bạn đọc (thông tin cá nhân = thông tin thẻ thư viện)
		-- Tìm bằng mã thẻ hoặc số điện thoại 
			select bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe 
			from (dbo.bandoc INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) 
			where( thethuvien.mathe = ' keyword 'OR bandoc.sdt = ' keyword ')
		-- tìm bằng tên (tìm kiếm tương đối)
			select bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe 
			from (dbo.bandoc INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) 
			where bandoc.ten like N'% keyword %'
	-- Tạo bạn đọc mới (mã bạn đọc và mã thẻ sẽ được cộng 1 tăng dần)
		-- Kiểm tra tính hợp lệ của số điện thoại(có tồn tại)(validate số điện thoại)
			SELECT COUNT(*) FROM dbo.bandoc Where bandoc.sdt = '{value}'
		-- lấy mã bạn đọc của bạn đọc cuối cùng
			WITH Ordered AS(
				SELECT ROW_NUMBER() OVER (ORDER BY bandoc.mabandoc) AS RowNumber, bandoc.mabandoc FROM dbo.bandoc)
			SELECT Ordered.mabandoc FROM Ordered
			WHERE RowNumber = (SELECT COUNT(bandoc.mabandoc) FROM bandoc)
		-- lấy mã thẻ của thẻ cuối cùng
			WITH Ordered AS(
				SELECT ROW_NUMBER() OVER (ORDER BY thethuvien.mathe) AS RowNumber, thethuvien.mathe FROM dbo.thethuvien)
			SELECT Ordered.mathe FROM Ordered
			WHERE RowNumber = (SELECT COUNT(thethuvien.mathe) FROM dbo.thethuvien)
		-- thêm thông tin bạn đọc mới vào database
			INSERT INTO dbo.bandoc values('{mabandoc}','{ten}','{sdt}','{diachi}','{ngaysinh}','{loi}')
		-- thêm thẻ thư viện mới cho bạn đọc mới 
			INSERT INTO dbo.thethuvien values('{mathe}','{mabandoc}',GETDATE(),'{hanthe}')
	-- Sửa dữ liệu thông tin bạn đọc(bao gồm cả thẻ thư viện)
		-- Sửa thông tin bạn đọc(bảng bandoc)
			UPDATE dbo.bandoc SET ten = N'tenbandoc', sdt = 'sodienthoai', diachi = N'diachi', ngaysinh ='ngaysinh' WHERE mabandoc = 'mabandoc';
		-- Gia hạn thẻ thư viện(thay đổi hạn thẻ)
			UPDATE dbo.thethuvien SET hanthe = 'ngayhethan' WHERE mathe = 'mathe';
-- 2.0 Quản lý mươn trả sách (Xong)
	-- Quản lý mượn sách
		-- Kiểm tra tính hợp lệ của bạn đọc
			-- kiểm tra thẻ hết hạn
				SELECT COUNT(*) FROM dbo.thethuvien
				WHERE (thethuvien.mathe = '{values}' AND thethuvien.hanthe < GETDATE())
			-- kiểm tra bạn đọc có mượn chưa trả hay không
				SELECT COUNT(*)FROM dbo.phieumuon
				WHERE (phieumuon.mathe =  '{values}'  AND phieumuon.ngaytra is NULL)	

			-- kiểm tra bạn đọc đã vi phạm quy định nhiều hơn 15
				SELECT COUNT(bandoc.mabandoc)FROM dbo.bandoc, dbo.thethuvien
				WHERE (thethuvien.mathe =  '{values}'  AND bandoc.mabandoc = thethuvien.mabandoc AND bandoc.loi > '15')	

			-- lấy số lần bạn đọc đã vi phạm quy định
				SELECT bandoc.loi FROM dbo.bandoc, dbo.thethuvien
				WHERE (bandoc.mabandoc = thethuvien.mabandoc AND thethuvien.mathe = '{values}')
		-- Kiểm tra tính hợp lệ của mã sách(có tồn tại)(validate Book ID)
			-- Kiểm tra sách có tồn tại hay không
				SELECT COUNT(*) FROM dbo.sach Where sach.masach = '{value}'
			-- Kiểm tra sách có đang được mượn hay không
				SELECT COUNT(chitietphieumuon.masach) FROM  dbo.chitietphieumuon, dbo.phieumuon
				WHERE (chitietphieumuon.masach = '{value}' AND chitietphieumuon.maphieumuon = phieumuon.maphieumuon AND phieumuon.ngaytra is NULL)
			-- Kiểm tra sách còn trong thư viện hay đã xuất khỏi thư viện
				SELECT COUNT(*) FROM dbo.sach Where (sach.masach = '{value}' AND sach.ngayxuat is NULL)
		-- Tạo phiếu mượn mới (mã phiếu mượn sẽ được cộng 1 tăng dần)
			-- lấy mã phiếu mượn của phiếu mượn cuối cùng
				WITH Ordered AS(
					SELECT ROW_NUMBER() OVER (ORDER BY phieumuon.maphieumuon) AS RowNumber, phieumuon.maphieumuon
					FROM dbo.phieumuon)
				SELECT Ordered.maphieumuon
				FROM Ordered
				WHERE RowNumber = (SELECT COUNT(phieumuon.maphieumuon) FROM phieumuon)
			-- lấy mã chi tiết của chi tiết phiếu mượn cuối cùng
				WITH Ordered AS(
					SELECT ROW_NUMBER() OVER (ORDER BY chitietphieumuon.machitiet) AS RowNumber, chitietphieumuon.machitiet
					FROM dbo.chitietphieumuon)
				SELECT Ordered.machitiet
				FROM Ordered
				WHERE RowNumber = (SELECT COUNT(chitietphieumuon.machitiet) FROM dbo.chitietphieumuon)
			-- Thêm phiếu mượn mới vào database
				INSERT INTO dbo.phieumuon(maphieumuon,mathe,ngayhentra,ngaymuon,ngaytra)
					values ('{value}','{value}','{value}',GETDATE(),NULL);
			-- Thêm chi tiết phiếu mượn mới vào database
				INSERT INTO dbo.chitietphieumuon(machitiet,maphieumuon,masach)  
					values ('{value}', '{value}', '{value}')
			-- Tăng thuộc tính lượt mượn của sách	
				UPDATE dbo.sach SET sach.luotmuon = sach.luotmuon + 1 WHERE sach.masach = '{value}'
	-- Quản lý trả sách
		-- Kiểm tra phiếu mượn có tồn tại hay không
				select * from dbo.phieumuon where phieumuon.maphieumuon = '{values}'
		-- cập nhật thông tin bạn đọc: +1 vi phạm lỗi quy định thư viện
				UPDATE dbo.bandoc SET bandoc.loi = bandoc.loi + '{values}' FROM dbo.bandoc, dbo.thethuvien
				WHERE (bandoc.mabandoc = thethuvien.mabandoc AND thethuvien.mathe = '{values}')
		-- Cập nhật phiếu mượn đã trả
				UPDATE dbo.phieumuon
				SET phieumuon.ngaytra = GETDATE()
				WHERE phieumuon.maphieumuon = '{values}' AND phieumuon.ngaytra is NULL;
-- 3.0 Quản lý kho sách(Xong)
	-- Hiển thị tất cả sách trong database
		SELECT * FROM dbo.sach ;
	-- Kiểm tra sách có tồn tại hay không
		SELECT COUNT(*) FROM dbo.sach Where sach.masach = '{value}'
	-- Tìm tương đối và in ra thông tin sách
		-- tìm kiếm bằng mã sách
			SELECT * FROM dbo.sach WHERE sach.masach ='{keyword}'
		-- tìm kiếm bằng tên sách(tìm kiếm tương đối)
			SELECT * FROM dbo.sach WHERE sach.tensach like N'%{keyword}%'
		-- Kiểm tra sách có đang được mượn hay không
			SELECT COUNT(chitietphieumuon.masach) FROM  dbo.chitietphieumuon, dbo.phieumuon
			WHERE (chitietphieumuon.masach = '{value}' AND chitietphieumuon.maphieumuon = phieumuon.maphieumuon AND phieumuon.ngaytra is NULL)
	-- Đánh dấu sách đã xuất(thêm trường giá trị ngày xuất)
			UPDATE dbo.sach SET sach.ngayxuat=GETDATE()
			WHERE sach.masach ='{value}' AND sach.ngayxuat is NULL;
	-- Thêm mới sách vào database
		INSERT INTO dbo.sach values ('masach', N'tensach', N'tentacgia', N'tinhtrangsach', '0', GETDATE(), NULL)
	-- Cập nhật thông tin sách (trường hợp nhập sai), và tình trạng sách(như mới, rách .....)
		UPDATE dbo.sach SET tensach =N'{value}', tentacgia =N'{value}', tinhtrangsach = N'{value}' WHERE sach.masach = '{value}'
-- 4.0 THống kê báo cáo (Xong)
	-- thong ke dau sach 
		-- Hiển thị tất cả sách trong database
			SELECT * FROM dbo.sach ;
		-- hien thi sach dang muon
			SELECT dbo.sach.masach, dbo.sach.tensach, dbo.sach.tentacgia, dbo.sach.tinhtrangsach, dbo.sach.luotmuon, dbo.sach.ngaynhap, dbo.sach.ngayxuat 
			FROM dbo.sach, dbo.chitietphieumuon, dbo.phieumuon 
			WHERE(dbo.sach.masach = dbo.chitietphieumuon.masach and dbo.chitietphieumuon.maphieumuon = dbo.phieumuon.maphieumuon and dbo.phieumuon.ngaytra is NULL);

	-- thong ke nhap xuat
		-- thong ke nhap theo theo ngay nhap
			SELECT * FROM dbo.sach 
			WHERE (dbo.sach.ngaynhap =>'{DATE}' AND dbo.sach.ngaynhap <= '{DATE}');
		-- thong ke xuat theo ngay xuat
			SELECT * FROM dbo.sach 
			WHERE (dbo.sach.ngayxuat >='{DATE}' AND dbo.sach.ngayxuat <= '{DATE}');

	-- thong ke ban doc
		-- hien thi tat ca thong tin ban doc
			SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe  
			FROM (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) ;
		-- hien thi tat ca ban doc co the qua han
			SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe  
			FROM (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc)
			WHERE (thethuvien.hanthe < GETDATE()) ;
		-- hien thi tat ca ban doc dang ky moi thang nay
			SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe  
			FROM (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc)
			WHERE (MONTH(thethuvien.ngaycap) = MONTH(GETDATE()) 
				AND YEAR(thethuvien.ngaycap) = YEAR(GETDATE()));	
		-- hien thi tat ca ban doc dang ky moi theo ngay tuy chon
			SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe  
			FROM (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc)
			WHERE (thethuvien.ngaycap >= '{DATE}' and thethuvien.ngaycap <= '{DATE}') ;

	-- thong ke muon, tra
		-- hien thi tat ca thong tin phieu muon            		
			SELECT * FROM dbo.phieumuon;	
		-- hien thi phieu muon trong thang							
			SELECT * FROM dbo.phieumuon
			WHERE (MONTH(dbo.phieumuon.ngaymuon) = MONTH(GETDATE()) 
				AND YEAR(dbo.phieumuon.ngaymuon) = YEAR(GETDATE()));
		-- hien thi phieu muon theo ngay tuy chon			
			SELECT * FROM dbo.phieumuon 
			WHERE (dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}');
		-- hien thi phieu muon dang muon			
			SELECT * FROM dbo.phieumuon 
			WHERE (dbo.phieumuon.ngaytra is NULL);
		-- hien thi phieu muon da tra trong thang         
			SELECT * FROM dbo.phieumuon 
			WHERE (MONTH(dbo.phieumuon.ngaytra) = MONTH(GETDATE()) 
				AND YEAR(dbo.phieumuon.ngaytra) = YEAR(GETDATE()));
		-- hien thi phieu muon da tra theo ngay tuy chon          
			SELECT * FROM dbo.phieumuon 
			WHERE (dbo.phieumuon.ngaytra >= '{DATE}' AND dbo.phieumuon.ngaytra <= '{DATE}');
		--hien thi chi tiet phieu muon cua tung phieu muon
			SELECT dbo.chitietphieumuon.masach, dbo.sach.tensach
			FROM (dbo.chitietphieumuon INNER JOIN dbo.sach ON dbo.chitietphieumuon.masach = dbo.sach.masach)
			WHERE (dbo.chitietphieumuon.maphieumuon = '{values}');
			
	-- thong ke bao cao hieu qua

		-- tổng lượt mượn(phiếu mượn) 
			SELECT COUNT(*) FROM dbo.phieumuon;
		-- tổng lượt mượn theo ngày, tháng(tháng này, tuỳ chọn)
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}');

		-- Tổng phiếu chưa trả
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NULL);
		-- tổng lượt mượn chưa trả theo ngày, tháng(tháng này, tuỳ chọn)
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}' 
			AND dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NULL);

		-- Tổng phiếu chưa trả quá hạn
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NULL);
		-- tổng lượt mượn chưa trả quá hạn theo ngày, tháng(tháng này, tuỳ chọn)
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}' 
			AND dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NULL);

		-- Tổng phiếu đã trả đúng hạn
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);
		-- tổng lượt đã trả theo ngày, tháng(tháng này, tuỳ chọn)
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}' 
			AND dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);

		-- Tổng phiếu đã trả quá hạn
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);
		-- tổng lượt đã trả quá hạn theo ngày, tháng(tháng này, tuỳ chọn)
			SELECT COUNT(*) FROM dbo.phieumuon
			WHERE (dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}' 
			AND dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);

		-- tỷ lệ phần trăm sách bị mượn quá hạn 

			-- tổng lượt mà các sách được mượn
				SELECT COUNT(*) FROM dbo.chitietphieumuon;
			-- tổng lượt mà các sách được mượn theo ngày, tháng(tháng này, tuỳ chọn)
				SELECT COUNT(*) FROM dbo.chitietphieumuon, dbo.phieumuon
				WHERE (dbo.chitietphieumuon.maphieumuon = dbo.phieumuon.maphieumuon AND dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}');

			-- Tổng lượt sách mượn quá hạn
				SELECT COUNT(chitietphieumuon.machitiet)
				FROM dbo.chitietphieumuon,dbo.phieumuon
				WHERE (chitietphieumuon.maphieumuon = phieumuon.maphieumuon AND (phieumuon.ngayhentra <= GETDATE() OR phieumuon.ngayhentra <= dbo.phieumuon.ngaytra))
			-- Tổng lượt sách mượn quá hạn theo ngày, tháng(tháng này, tuỳ chọn)
				SELECT COUNT(chitietphieumuon.machitiet) 
				FROM dbo.chitietphieumuon,dbo.phieumuon
				WHERE(chitietphieumuon.maphieumuon = phieumuon.maphieumuon 
				AND dbo.phieumuon.ngaymuon >='{DATE}' AND dbo.phieumuon.ngaymuon <= '{DATE}'
				AND (phieumuon.ngayhentra <= GETDATE() OR phieumuon.ngayhentra <= dbo.phieumuon.ngaytra) )

		-- lượt mượn từng đầu sách 
			SELECT CountTable.masach,dbo.sach.tensach, CountTable.Luotmuon
			FROM(
				(
				SELECT  sach.masach, COUNT(chitietphieumuon.machitiet) as Luotmuon
					FROM  dbo.sach LEFT JOIN dbo.chitietphieumuon
					ON chitietphieumuon.masach = sach.masach
					GROUP BY (sach.masach)
				) CountTable INNER JOIN dbo.sach ON CountTable.masach = dbo.sach.masach
			)	
		-- lượt mượn từng đầu sách theo ngày, tháng(tháng này, tuỳ chọn)
			SELECT CountTable.masach,dbo.sach.tensach, CountTable.Luotmuon
			FROM(
				(
				SELECT  sach.masach, COUNT(chitietphieumuon.machitiet) as Luotmuon
					FROM  dbo.sach LEFT JOIN dbo.chitietphieumuon
					ON chitietphieumuon.masach = sach.masach
					GROUP BY (sach.masach)
				) CountTable INNER JOIN dbo.sach ON CountTable.masach = dbo.sach.masach
			)	

--  END OF DOCUMENT
