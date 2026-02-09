# 🍔 Food Delivery System – Low Level Design (C#)

This repository contains a **clean, modular Low Level Design** for a **Food Delivery System** similar to popular online food ordering platforms.  
The system is implemented in **C#**, following **Clean Architecture**, **SOLID principles**, and real-world domain modeling.

The design focuses on **clarity, extensibility, and correctness**, making it suitable for learning, reference, or further production-level expansion.

---

## ✨ Features

- Customer management
- Restaurant onboarding and menu management
- Order creation and lifecycle handling
- Order status tracking
- Payment processing abstraction
- Thread-safe in-memory data storage
- Clear separation of concerns across layers

---

## 🏗️ Architecture Overview

The system is divided into four logical layers:

-Presentation (Console App)
-Application Layer (Services & Interfaces)
-Domain Layer (Entities, Enums, Value Objects)
-Infrastructure Layer (Repositories, External Services)


This ensures:
- Loose coupling
- Easy testability
- Replaceable infrastructure components (DB, payment gateways, etc.)

---

## 🧠 Domain Model

### Key Entities
- **Customer** – places orders
- **Restaurant** – owns menu items
- **MenuItem** – food item with price
- **Order** – represents a food order and its lifecycle

### Order Status Flow
-Placed → Accepted → Preparing → PickedUp → Delivered


---

## 🔧 Application Layer

The application layer orchestrates business use cases such as:
- Placing an order
- Processing payments
- Updating order status

It depends only on **interfaces**, not concrete implementations.

---

## 🛠️ Infrastructure Layer

- **InMemoryOrderRepository**
  - Thread-safe order storage using `ConcurrentDictionary`
- **DummyPaymentService**
  - Simulates payment processing
  - Can be replaced with real payment gateway integration

---

## ▶️ Running the Application

1. Open the solution in Visual Studio
2. Set `FoodDeliverySystem.ConsoleApp` as the startup project
3. Run the application

Sample flow:
- Create customer
- Create restaurant and menu
- Place order
- Process payment
- Display order ID

---

## 🔄 Extensibility

This design allows easy addition of:

- Delivery partner assignment
- Order cancellation and refunds
- Coupon and discount system
- Notifications (SMS / Email / Push)
- Persistent storage (SQL / NoSQL)
- REST APIs using ASP.NET Core
- Event-driven workflows

---

## 📌 Design Principles Used

- Single Responsibility Principle
- Open/Closed Principle
- Dependency Inversion
- Composition over inheritance
- Domain-driven naming and structure

---

## Author

-Abhishek Keshri


