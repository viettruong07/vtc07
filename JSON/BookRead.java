package JSON;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class BookRead {
    public static void main(String[] args) {
        JSONParser jsonBook = new JSONParser();
        try(FileReader reader = new FileReader("book.json")){
            Object obj = jsonBook.parse(reader);

            JSONArray BookList = (JSONArray) obj;
            System.out.println(BookList);

            BookList.forEach( book -> parseBookObject( (JSONObject) book) );
        }catch (FileNotFoundException e){
            e.printStackTrace();
        }catch (IOException e){
            e.printStackTrace();
        }catch (ParseException e){
            e.printStackTrace();
        }
    }

    private static void parseBookObject(JSONObject book){
        JSONObject BookObject1 = (JSONObject) book.get("book");

        String id = (String) BookObject1.get("id");
        System.out.println(id);

        String name = (String) BookObject1.get("name");
        System.out.println(name);

        String price = (String) BookObject1.get("price");
        System.out.println(price);

        String author = (String) BookObject1.get("author");
        System.out.println(author);
    }
}
