package BaiThiJava2;

public class Student {
    private String StudentID;
    private String StudentName;
    private String Address;
    private int Phone;

    public Student(String StudentID, String StudentName, String Address, int Phone) {
        this.StudentID = StudentID;
        this.StudentName = StudentName;
        this.Address = Address;
        this.Phone = Phone;
    }

    public String getStudentID() {
        return StudentID;
    }

    public void setStudentID(String studentID) {
        StudentID = studentID;
    }

    public String getStudentName() {
        return StudentName;
    }

    public void setStudentName(String studentName) {
        StudentName = studentName;
    }

    public String getAddress() {
        return Address;
    }

    public void setAddress(String address) {
        Address = address;
    }

    public int getPhone() {
        return Phone;
    }

    public void setPhone(int phone) {
        Phone = phone;
    }
}
