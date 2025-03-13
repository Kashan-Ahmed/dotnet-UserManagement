# dotnet-UserManagement
UserManagement-Coursera-Project

# **User Management API** 🚀  
A simple **ASP.NET Core Web API** for managing users with in-memory storage, CRUD operations, validation, and logging middleware.  

---

## **📌 Features**
✅ **CRUD Operations:** `GET, POST, PUT, DELETE` for user management  
✅ **Validation:** Ensures only valid user data is processed  
✅ **Middleware:** Custom **logging middleware** for request tracking  
✅ **GitHub Repository:** This project is version-controlled with Git & GitHub  
✅ **Copilot Assistance:** Used to debug & improve code efficiency  

---

## **🛠️ Setup Instructions**
### **1️⃣ Clone the Repository**
```bash
git clone https://github.com/your-username/UserManagementAPI.git
cd UserManagementAPI
```

### **2️⃣ Build & Run the Project**
```bash
dotnet build
dotnet run
```

### **3️⃣ API Endpoints & Usage**
Base URL: `http://localhost:5000/api/users`  

| Method | Endpoint         | Description            | Example Request |
|--------|----------------|------------------------|----------------|
| `GET`  | `/api/users`   | Get all users         | `curl -X GET http://localhost:5000/api/users` |
| `GET`  | `/api/users/{id}` | Get a user by ID  | `curl -X GET http://localhost:5000/api/users/1` |
| `POST` | `/api/users`    | Create a new user     | `curl -X POST -H "Content-Type: application/json" -d '{"firstName": "John", "lastName": "Doe", "email": "john@example.com", "password": "123456", "phone": "1234567890"}' http://localhost:5000/api/users` |
| `PUT`  | `/api/users/{id}` | Update a user  | `curl -X PUT -H "Content-Type: application/json" -d '{"firstName": "Updated", "lastName": "User"}' http://localhost:5000/api/users/1` |
| `DELETE` | `/api/users/{id}` | Delete a user | `curl -X DELETE http://localhost:5000/api/users/1` |

### **4️⃣ Open API Docs (Swagger)**
After running the project, open:  
🔗 **Swagger UI** → [http://localhost:5000/swagger](http://localhost:5000/swagger)  

---

## **📂 Project Structure**
```
UserManagementAPI
│── Middlewares
│   ├── LoggingMiddleware.cs       # Custom logging middleware
│── Extensions
│   ├── LoggingMiddlewareExtensions.cs  # Middleware registration
│── Controllers
│   ├── UserController.cs          # API controller for user CRUD
│── Repositories
│   ├── UserRepository.cs          # In-memory user storage
│── Models
│   ├── User.cs                    # User data model
│── Program.cs                      # App entry point, middleware setup
```

---

## **🛡️ Implemented Functionalities**
### ✅ **GitHub Repository**
This project is managed in a **GitHub repository** for version control and collaboration.  

### ✅ **CRUD Endpoints**
The API provides all necessary **Create, Read, Update, and Delete** operations for user management.  

### ✅ **Copilot Debugging**
**Copilot** was used to optimize code, suggest best practices, and debug any errors.  

### ✅ **Data Validation**
- Ensures required fields (`FirstName`, `Email`) are provided  
- Prevents invalid data submission  

### ✅ **Middleware Integration**
- **Custom Logging Middleware** logs request details and execution time  
- Can be extended for **authentication** in the future  

---

## **📌 Future Enhancements**
🔹 **JWT Authentication** for securing endpoints  
🔹 **Database Integration** using **Entity Framework Core**  
🔹 **Unit Tests** for API endpoints  

---

## **📞 Support**
For any questions or issues, feel free to **raise an issue** in the repository.  
Happy Coding! 🚀🎯  

---

Does this look good to you? Let me know if you'd like any modifications! 😊
