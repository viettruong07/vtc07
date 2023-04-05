package BaiThiJava2;

import java.sql.*;
import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;
public class TestStudent {
    public static void main(String[] args) {
        try(
                Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/create_account", "root", "");
                Statement stmt = conn.createStatement();

                ){
            do {
                ArrayList<Student> students = new ArrayList<>();
                Scanner in = new Scanner(System.in);
                System.out.println("1.Thêm hồ sơ sinh viên \n2.Hiển thị hồ sơ sinh viên \n3.Lưu \n4.Thoát ");
                System.out.printf("Vui lòng chọn: ");
                int option = in.nextInt();
                in.nextLine();
                switch (option) {
                    case 1:
                        System.out.printf("Nhập StudentID: ");
                        String StudentID = in.nextLine();
                        System.out.printf("Nhập StudentName: ");
                        String StudentName = in.nextLine();
                        System.out.printf("Nhập Address: ");
                        String Address = in.nextLine();
                        System.out.printf("Nhập Phone: ");
                        int Phone = in.nextInt();
                        in.nextLine();

                        String add = "insert into student(StudentID, StudentName,Address, Phone) values(?,?,?,?)";
                        PreparedStatement pstm = conn.prepareStatement(add);
                        pstm.setString(1, StudentID);
                        pstm.setString(2, StudentName);
                        pstm.setString(3, Address);
                        pstm.setInt(4, Phone);
                        int checkAdd = pstm.executeUpdate();
                        if (checkAdd >= 1){
                            System.out.println("Số dòng bị ảnh hưởng: " + checkAdd);
                            System.out.println("Thêm thành công");
                        }else{
                            System.out.println("Số dòng bị ảnh hưởng: " + checkAdd);
                            System.out.println("Thêm thất bại");
                        }
                        break;
                    case 2:
                        String select = "select * from student";
                        PreparedStatement pstm2 = conn.prepareStatement(select);
                        ResultSet rs = pstm2.executeQuery();
                        ResultSetMetaData RSMD = rs.getMetaData();
                        int countSelect = RSMD.getColumnCount();
                        for (int i = 1; i <= countSelect; ++i){
                            System.out.printf("%-30s", RSMD.getColumnName(i));
                        }
                        System.out.println();
                        for (int i = 1; i <= countSelect; ++i){
                            System.out.printf("%-30s", "(" + RSMD.getColumnClassName(i) + ")");
                        }
                        System.out.println();
                        while (rs.next()){
                            for (int i = 1; i <= countSelect; ++i){
                                System.out.printf("%-30s", rs.getString(i));
                            }
                            System.out.println();
                        }
                        break;
                    case 3:
                            for (Student student : students) {
                                System.out.println(student.getStudentID() + "," + student.getStudentName() + "," + student.getAddress() + "," + student.getPhone());
                            }
                        break;
                    case 4:
                        return;

                }
            }while (true);


        }catch (SQLException e){
            throw new RuntimeException(e);
        }
    }
}
