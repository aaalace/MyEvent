# MyEvent API

---
- [MyEvent API](#myevent-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register request](#register-request)
      - [Register response](#register-response)
    - [Login](#login)
---

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register request

```json
{
  "firstName": "Almaz",
  "lastName": "Tazeev",
  "email": "mymail@gmail.com",
  "password": "password"
}
```

#### Register response

```js
200 OK
```
```json
{
  "id": "123456789",
  "firstName": "Almaz",
  "lastName": "Tazeev",
  "email": "mymail@gmail.com",
  "token": "fgEks..z9wdqfKiN"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login request

```json
{
  "email": "mymail@gmail.com",
  "password": "password"
}
```

#### Login response

```json
{
  "id": "123456789",
  "firstName": "Almaz",
  "lastName": "Tazeev",
  "email": "mymail@gmail.com",
  "token": "fgEks..z9wdqfKiN"
}
```