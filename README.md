# Turkiye Provinces

This project is a web API developed using ASP.NET Core for managing city data. The API provides endpoints for common CRUD (Create, Read, Update, Delete) operations and is integrated with NHibernate for database interactions. Below is a comprehensive guide to understanding and using the project.

---

## Features

- **Retrieve all cities**: Get a list of all cities stored in the database.
- **Get city by ID**: Fetch detailed information about a specific city using its unique ID.
- **Add a new city**: Create and store new city data in the database.
- **Update existing city**: Modify details of an existing city.
- **Delete a city**: Remove a city from the database.

---

## Technologies Used

- **ASP.NET Core**: Backend framework for building APIs.
- **NHibernate**: ORM (Object Relational Mapper) for database operations.
- **SQL Database**: For data persistence.

---

## Endpoints

### Base URL: `[controller]`

### 1. **Get All Cities**
**GET /cities**
- Description: Retrieves a list of all cities.
- Response: A list of city objects or a 404 if no cities are found.

Example Response:
```json
[
  {
        "id": 1,
        "name": "Adana",
        "plate": 1
    },
    {
        "id": 2,
        "name": "Adıyaman",
        "plate": 2
    }
]
```

### 2. **Get City By ID**
**GET /cities/{id}**
- Description: Fetches details of a specific city by its ID.
- Response: The city object or a 404 if not found.

### 3. **Add a City**
**POST /cities**
- Description: Adds a new city to the database.
- Request Body:
```json
{
        "id": 27,
        "name": "Gaziantep",
        "plate": 27
    }
```
- Response: The created city object with its new ID.

### 4. **Update a City**
**PUT /cities/{id}**
- Description: Updates an existing city’s details.
- Request Body:
```json
{
        "id": 34,
        "name": "İstanbul",
        "plate": 34
    }
```
- Response: HTTP 204 (No Content) if successful or HTTP 404 if the city is not found.

### 5. **Delete a City**
**DELETE /cities/{id}**
- Description: Deletes a city from the database.
- Response: HTTP 204 (No Content) if successful or HTTP 404 if the city is not found.

---

## Error Handling

- **404 Not Found**: Returned when a requested resource (city) is not found.
- **400 Bad Request**: Returned when invalid data is provided.
- **500 Internal Server Error**: Returned when an unexpected error occurs.

---


## License

This project is licensed under the MIT License. See the LICENSE file for details.

---
