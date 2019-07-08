# AspNetCore.Security.Jwt.IdentityMicroservice

## Demonstrates Identity Microservice approach to micro services security.

The solution implements an **Identity Microservice security architecture** using the package.

The security architecture is depicted in the below diagram.

![Identity Microservice architecture](https://github.com/VeritasSoftware/AspNetCore.Security.Jwt.IdentityMicroservice/blob/master/IdentityMicroserviceAuth.png)

The Identity Microservice does the authentication and serves the JWT token.

Also, another Api which uses the Authorization token.
The Api uses the **Security Client** for the Swagger integration.
The Client renders an **Authorize** button in Swagger to post the token the secured Api endpoint.

The Api endpoint is secured by the **Authorize** attribute.