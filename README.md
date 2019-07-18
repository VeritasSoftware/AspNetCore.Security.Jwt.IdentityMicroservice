# AspNetCore.Security.Jwt.IdentityMicroservice

[![Build Status](https://travis-ci.com/VeritasSoftware/AspNetCore.Security.Jwt.IdentityMicroservice.svg?branch=master)](https://travis-ci.com/VeritasSoftware/AspNetCore.Security.Jwt.IdentityMicroservice)

## Demonstrates Identity Microservice approach to micro services security.

The solution implements an **Identity Microservice security architecture** using the package [**AspNetCore.Security.Jwt**](https://github.com/VeritasSoftware/AspNetCore.Security.Jwt).

This Microsoft recommended security architecture is depicted in the below diagram.

![Identity Microservice architecture](https://github.com/VeritasSoftware/AspNetCore.Security.Jwt.IdentityMicroservice/blob/master/IdentityMicroserviceAuth.png)

The solution comprises of 2 projects.

## Projects

### XYZ.IdentityMicroservice

The Identity Microservice does the authentication and serves the JWT token.

![Identity Microservice Swagger](https://github.com/VeritasSoftware/AspNetCore.Security.Jwt.IdentityMicroservice/blob/master/IdentityMicroserviceSwagger.png)

### XYZ.Api

The Api uses the token.

The Api uses the **Security Client** for the Swagger integration.

The Client renders an **Authorize** button in Swagger to post the token tothe secured Api endpoint.

The Api endpoint is secured by the **Authorize** attribute.

![Client API Swagger](https://github.com/VeritasSoftware/AspNetCore.Security.Jwt.IdentityMicroservice/blob/master/ClientAPISwagger.png)