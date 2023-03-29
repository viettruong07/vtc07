module tcv0707.viettc2004 {
    requires javafx.controls;
    requires javafx.fxml;

    requires org.controlsfx.controls;
    requires com.dlsc.formsfx;
    requires net.synedra.validatorfx;
    requires org.kordamp.bootstrapfx.core;

    opens tcv0707.viettc2004 to javafx.fxml;
    exports tcv0707.viettc2004;
    requires java.sql;
}