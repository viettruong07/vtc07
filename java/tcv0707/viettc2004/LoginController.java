package tcv0707.viettc2004;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;

import java.sql.*;
import java.util.*;

public class LoginController {
    @FXML
    private Label alert;
    @FXML
    private TextField txtUsername;

    @FXML
    private PasswordField txtPassword;

    @FXML
    private Button btnLogin;

    @FXML
    private Button btnReset;

    public void onLogin(ActionEvent actionEvent) throws SQLException {
        String username = txtUsername.getText();
        String password = txtPassword.getText();

        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/create_account", "root", "");
        PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM  user where Email = ? and Password = ?");

        pstmt.setString(1, username);
        pstmt.setString(2, password);
        pstmt.addBatch();
        ResultSet check = pstmt.executeQuery();
        int i = 0;
        while (check.next()) {
            i++;
        }

        if (i >= 1) {
            alert.setText("Đăng Nhập Thành Công");
        } else
            alert.setText("Vui Lòng Nhập Lại");


    }

    public void onReset(ActionEvent actionEvent){

    }
}
