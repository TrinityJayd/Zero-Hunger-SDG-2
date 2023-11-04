# MVC Application for Sustainable Agriculture

Welcome to the MVC Application for Sustainable Agriculture project! This is a C# MVC application designed to address Sustainable Development Goal (SDG) #2: "Zero Hunger." The primary objective is to create an application that assists farmers in managing their crop yields, expenses, and profits, with the goal of promoting sustainable farming practices and reducing food insecurity.

## Table of Contents
- [Objective](#objective)
- [Scenario](#scenario)
- [Requirements](#requirements)
- [Activity Steps](#activity-steps)

## Objective

The objective of this project is to develop a Model-View-Controller (MVC) application using C# that contributes to the achievement of Sustainable Development Goal (SDG) #2, "Zero Hunger." The application aims to assist farmers in keeping track of their crop yields, expenses, and profits, ultimately promoting sustainable farming practices and reducing food insecurity.

## Scenario

Imagine you are part of a team working on a project to promote sustainable agriculture in your local community. Your role is to create a C# MVC application that enables farmers to manage and monitor their crop-related data effectively.

## Requirements

### Model (M):

1. Create a `Crop` class with the following attributes:
   - `CropName` (string)
   - `CropYield` (int) - representing the quantity of the crop harvested.
   - `CropExpenses` (double) - representing the total expenses incurred for cultivating the crop.
   - `CropIncome` (double) - representing the income generated from selling the crop.

2. Implement a `CropRepository` class that manages a list of crops.

### View (V):

1. Design a user-friendly interface that allows users to:
   - Add a new crop with its name, yield, expenses, and income.
   - View a list of crops and their details.
   - Calculate the total yield, total expenses, and total income for all crops.

### Controller (C):

1. Create a controller that interacts with the view and the model.
2. Implement methods in the controller to:
   - Add a new crop to the repository.
   - Retrieve the list of crops from the repository.
   - Calculate and update the total yield, expenses, and income.

## Activity Steps

1. **Model (M)**:
   - Create the `Crop` class with appropriate properties and constructors.
   - Implement the `CropRepository` class to manage crops.

2. **View (V)**:
   - Include input fields for adding new crops and a display area for showing crop details.
   - Provide buttons for adding crops and viewing statistics.

3. **Controller (C)**:
   - Create a controller class to handle user actions and interactions between the model and view.
   - Implement methods for adding crops, retrieving crop data, and calculating statistics.

4. **Application Workflow**:
   - The application uses an Azure SQL Database to demonstrate system usage. 
   - Users can use the interface to add details of the crops they cultivate.
   - The application should validate user input and handle errors gracefully.
   - Users can view the list of crops and see statistics on total yield, expenses, and income.
   - Ensure that the application promotes sustainable farming practices, such as reducing expenses and increasing yield.
