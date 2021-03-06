# .netCore Web App
## DEMO 

![alt text](https://github.com/KhatijaHusain/React-app-TS-with-.net-core/blob/master/React-App/public/BlogDemo.gif)

## Features
1. Repository Pattern
2. RestFull Services
3. Swagger enabled (Rest Service specific action)
4. Dependency Injection


## API

### Get all BlogPosts
```http
GET /blogposts
```
#### Response
```javascript
[
    {
        "blogpostid": 1,
        "body": "This is a love letter to Swedish summer – to walking barefoot, swimming in lakes, eating strawberries every day, making potato sandwiches and cooking a delicious zucchini soup with lots of toppings.",
        "title": "Worlds top 10 books",
        "publishedOn": "2020-02-01T00:00:00",
        "blogComment": [
            {
                "commentId": 1,
                "comment": "Lovely post",
                "commentedOn": "2022-03-06T17:47:56.510446"
            }
         ]
      }
 ]
```

---
### Get a blogpost by its id
```http
GET /blogposts/{blogpostid}
```
#### Response
```javascript
{
    "blogpostid": 2,
    "body": "Here is a great weeknight dinner that comes together on the stove in just under 20 minutes. Soft, sticky and flavor-packed aubergine meets crunchy broccoli and earthy noodles. Heaven in a bowl.",
    "title": "How to bake a cake",
    "publishedOn": "2020-02-01T00:00:00",
    "blogComment": []
}
```

