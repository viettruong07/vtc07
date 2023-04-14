package JSON;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import java.io.FileWriter;
import java.io.IOException;

public class BookWrite {
    @SuppressWarnings("unchecked")
    public static void main(String[] args) {
        JSONObject Book1 =new JSONObject();
        Book1.put("id","1");
        Book1.put("name","Boy Friends");
        Book1.put("price","$100");
        Book1.put("author","TCV");

        JSONObject BookObject = new JSONObject();
        BookObject.put("Book", Book1);

        JSONObject Book2 = new JSONObject();
        Book2.put("id", "2");
        Book2.put("name","Girl Friends");
        Book2.put("price","$99");
        Book2.put("author","TCV");

        JSONObject BookObject2 = new JSONObject();
        BookObject2.put("Book", Book2);

        JSONArray BookList = new JSONArray();
        BookList.add(BookObject);
        BookList.add(BookObject2);

        try (FileWriter file = new FileWriter("book.json")){
            file.write(BookList.toJSONString());
            file.flush();
        }catch (IOException e){
            e.printStackTrace();
        }
    }
}
