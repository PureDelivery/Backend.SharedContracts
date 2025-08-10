# Backend.SharedContracts
📚 Shared contracts, DTOs, events, and interfaces for Pure Delivery microservices. Published as NuGet package to GitHub Packages for cross-service communication and data consistency.

[3.0.6] [11.08.2025]
- Created SearchDishInRestaurantRequest to separate two different flows

[3.0.5] [11.08.2025]
- Restaurant requests to have shared LocationRequestBase

[3.0.4] [09.08.2025]
- EstimatedDelivery model created to have a estimated minutes whole delivery range

[3.0.3] [09.08.2025]
- EstimatedDeliveryMinutes added to restaurant dto

[3.0.2] [09.08.2025]
- Delivery zone data request extended

[3.0.1] [07.08.2025]
- Coordinates fields added to restaurant

[3.0.0] [07.08.2025]
- Added models for location service

[2.0.3] [07.08.2025]
- Added Longitude Latitude fields type changed to decimal

[2.0.2] [07.08.2025]
- Added Longitude Latitude fields to RestaurantDto model

[2.0.1] [03.08.2025]
- Removed old filter models and added model for joined restaurant filtering

[2.0.0] [01.08.2025]
- Added Restaurant Service DTOs and request models
- Added PagedResult<T> model for pagination support
- Added restaurant filtering and search request models
- Added menu item and nutrition DTOs with options support
- Added cuisine type and restaurant tag filtering models

[1.9.0] [30.07.2025]
- Added new models for separated profile dtos, changed summary dto

[1.8.3] [29.07.2025]
- Change pasword functionality extended, thus, new models created: PasswordChangeRequest and ChangePasswordWithOtpRequest

[1.8.2] [28.07.2025]
- CreateAddressRequest added IsDefault property

[1.8.1] 
- CustomerProfileDto to support Avatar and User grade data

[1.8.0] 
- Remove PaymentMethod field from CreateCustomerRequest

[1.7.8] [24.07.2025]
- Added LoyaltyPointsRequest, GradeCustomerRequest, UpdateLastOrderDateRequest

[1.7.7] [24.07.2025]
- Added ConfirmEmailRequest and ResendOtpRequest

[1.7.6] [24.07.2025]
- Added Identity request models: CreateAddressRequest, UpdateAddressRequest, UpdateProfileRequest
- Added DataAnnotations validation attributes for all request models

[1.7.5] [15.07.2025]
- ISessionService: add param AuthRequest to ISessionService create with add customer info to store session security info

[1.7.4] [15.07.2025]
- ISessionService: return type of Validation method changed

[1.7.3] [15.07.2025]
- ISessionService: changed validation method params

[1.7.0] [15.07.2025]
- ISessionService extend
- SessionDTO extend

[1.6.2] [13.07.2025]
- Request models added

[1.6.1] [13.07.2025]
- ISessionService interface adjusted to return string values 

[1.6.0] [13.07.2025]
- Identity DTOs added

[1.5.1] [13.07.2025]
- ISessionService fix return value

[1.5.0] [13.07.2025]
- ISessionService adjusted to Identity Microservice
- Added new session models for Identity Microservice

[1.4.0] [12.07.2025]
- Added BaseResponse model

[1.3.0] [09.07.2025]
- Removed ApiResponse model. Moved to separate project

[1.2.0] [09.07.2025]
- Added ISessionService contract for infrastructure connection

[1.1.0] [08.07.2025]
- ApiResponse model added

[1.0.0] [08.07.2025]
- Initial contracts