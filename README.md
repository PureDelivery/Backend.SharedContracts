# Backend.SharedContracts
📚 Shared contracts, DTOs, events, and interfaces for Pure Delivery microservices. Published as NuGet package to GitHub Packages for cross-service communication and data consistency.

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