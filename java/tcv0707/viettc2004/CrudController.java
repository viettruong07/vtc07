package tcv0707.viettc2004;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.VBox;
import java.net.ConnectException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Collection;
import java.sql.*;

public class CrudController {
    @FXML
    private TextField txtID;
    @FXML
    private TextField txtName;
    @FXML
    private TextField txtPrice;
    @FXML
    private TextField txtDescription;
    @FXML
    private TextField txtQty;
    @FXML
    private Button btnAdd;
    @FXML
    private Button btnUpdate;
    @FXML
    private Button btnDelete;
    @FXML
    private Label label;

    public void OnAdd(ActionEvent actionEvent) {
        if(txtName.getText().isBlank() == false || txtPrice.getText().isBlank() == false  || txtDescription.getText().isBlank() == false  || txtQty.getText().isBlank() == false ){
            try {
                Connection cn = DriverManager.getConnection("jdbc:mysql://localhost:3306/crud","root","");
                String insert = "insert into product(Name, Price, Description, Qty) values(?,?,?,?)";
                PreparedStatement pstm =  cn.prepareStatement(insert);
                pstm.setString(1,txtName.getText());
                pstm.setString(2,txtPrice.getText());
                pstm.setString(3,txtDescription.getText());
                pstm.setString(4,txtQty.getText());
                int check = pstm.executeUpdate();

                if(check > 0){
                    label.setText("Thêm thành công");
                }else{
                    label.setText("Lỗi cú pháp");
                }

            }catch (Exception e){
                label.setText("Lỗi kết nối cơ sở dữ liệu");
            }

        }else{
            label.setText("Hãy điền thông tin đầy đủ");
        }

    }
    public void OnUpdate(ActionEvent actionEvent){
        if( txtID.getText().isBlank() == false || txtName.getText().isBlank() == false || txtPrice.getText().isBlank() == false  || txtDescription.getText().isBlank() == false  || txtQty.getText().isBlank() == false ) {
            try {
                Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/crud", "root", "");
                String sql1 = "update product set Name = ?,Description = ?, Price = ?, Qty = ? WHERE id = ? ";
                PreparedStatement updates = conn.prepareStatement(sql1);
                updates.setString(1, txtName.getText());
                updates.setString(2, txtDescription.getText());
                updates.setString(3, txtPrice.getText());
                updates.setString(4, txtQty.getText());
                updates.setString(5, txtID.getText());
                int upd = updates.executeUpdate();
                if (upd > 0) {
                    label.setText("Update thành công");
                } else {
                    label.setText("Update thất bại");
                }
            } catch (Exception e) {
                label.setText("Lỗi kết nối cơ sở dữ liệu");
            }
        }else{
            label.setText("Hãy điền thông tin đầy đủ");
        }

    }
    public void OnDelete(ActionEvent actionEvent){
        if(txtID.getText().isBlank() == false) {
            try {
                Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/crud", "root", "");
                String sql1 = "delete from product where id = ?";
                PreparedStatement delete = conn.prepareStatement(sql1);

                delete.setString(1, txtID.getText());
                int delete1 = delete.executeUpdate();
                if (delete1 > 0) {
                    label.setText("Xoá thành công");
                } else {
                    label.setText("Xoá thất bại");
                }
            } catch (SQLException e) {
                label.setText("Lỗi kết nối cơ sở dữ liệu");
            }
        }else{
            label.setText("Hãy điền thông tin đầy đủ");
        }
    }
}
