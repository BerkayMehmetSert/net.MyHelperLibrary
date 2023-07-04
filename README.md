# Net My Helper Library

## Description

This is a project of functions that I have created to help me with my projects. I have decided to make it public in case
anyone else finds it useful.

## Installation

1. Clone the repository

```bash
git clone https://github.com/BerkayMehmetSert/net.MyHelperLibrary.git
```

2. Install the dependencies

```bash
dotnet restore
```

3. Test the project

```bash
dotnet test
```

## Usage

### Code

**Generate Code**

```bash
GET /api/code/generate-code/{length}
```

Response body:

```json
{
  "code": "string"
}
```

## Date

**Get Current Date Time Utc**

```bash
GET /api/date/get-current-date-time-utc
```

Response body:

```json
{
  "date": "2023-07-04T00:00:00.000Z"
}
```

**Get Current Date Time Utc With Format**

```bash
GET /api/date/get-current-date-time-utc-with-format/{format}
```

Response body:

```json
{
  "date": "2023-07-04"
}
```

**Get Current Date Time**

```bash
GET /api/date/get-current-date-time
```

Response body:

```json
{
  "date": "2023-07-04"
}
```

**Get Current Date Time With Format**

```bash
GET /api/date/get-current-date-time-with-format/{format}
```

Response body:

```json
{
  "date": "2023-07-04"
}
```

**Get Previous Date Time Utc**

```bash
GET /api/date/get-previous-date-time-utc/{days}
```

Response body:

```json
{
  "date": "2023-07-03T00:00:00.000Z"
}
```

**Get Previous Date Time Utc With Format**

```bash
GET /api/date/get-previous-date-time-utc-with-format/{days}/{format}
```

Response body:

```json
{
  "date": "2023-07-03"
}
```

**Get Previous Date Time**

```bash
GET /api/date/get-previous-date-time/{days}
```

Response body:

```json
{
  "date": "2023-07-03"
}
```

**Get Previous Date Time With Format**

```bash
GET /api/date/get-previous-date-time-with-format/{days}/{format}
```

Response body:

```json
{
  "date": "2023-07-03"
}
```

**Get Next Date Time Utc**

```bash
GET /api/date/get-next-date-time-utc/{days}
```

Response body:

```json
{
  "date": "2023-07-05T00:00:00.000Z"
}
```

**Get Next Date Time Utc With Format**

```bash
GET /api/date/get-next-date-time-utc-with-format/{days}/{format}
```

Response body:

```json
{
  "date": "2023-07-05"
}
```

## Exception

**Get Business Exception**

```bash
GET /api/exception/business-exception/{message}
```

Response body:

```json
{
  "type": "https://example.com/probs/business",
  "title": "Business error",
  "status": 400,
  "detail": "message",
  "instance": null
}
```

**Get Not Found Exception**

```bash
GET /api/exception/not-found-exception/{message}
```

Response body:

```json
{
  "type": "https://example.com/probs/not-found",
  "title": "Not found error",
  "status": 404,
  "detail": "message",
  "instance": null
}
```

**Get Exception**

```bash
GET /api/exception/exception/{message}
```

Response body:

```json
{
  "type": "https://example.com/probs/internal-server-error",
  "title": "Internal server error",
  "status": 500,
  "detail": "message",
  "instance": null
}
```

## Security

**Create Password Hash 512**

```bash
POST /api/security/create-password-hash-512/{password}
```

Response body:

```json
{
  "passwordHash": "gxmtqPrAN4lNOinkAM6CVo41PlyvfSXhJ7HpXd5PDmFDYId5CPJm29PyoRKcuGkTvgXkHlR5f6x/jvi/WJtqsw==",
  "passwordSalt": "3NuGL0183Sv/zaBcLDdGDUSuYX5gN5QyNCCPr3y05XwNqiQD/iYwvrA3+JdHsQz6uUeh3mijV5ILAqY4yo/vnjGeEsqlNNk+FbY5KU6oNCcKJeM/XlMaVIk04lcndKwdcQHCdZ/EVD2pTOiMRIJXtRVuCTu6h3Yg7Ic2HoewnK4="
}
```

**Create Password Hash 256**

```bash
POST /api/security/create-password-hash-256/{password}
```

Response body:

```json
{
  "passwordHash": "T/5qVCJWGkEmrkih2vv3pXGjW2RiKj64V4rXZr3941o=",
  "passwordSalt": "7s2v9ElwSvdmwFvztfJ3ZTe3yT+Qn/MmQb1Od33x8okbbDYLcsMZiS3m8665xFxUCgHfNX+J8oAfufDSFh4nKQ=="
}
```

**Create Security Key**

```bash
GET /api/security/create-security-key/{securityKey}
```

Response body:

```json
{
  "securityKey": {
    "keySize": 24,
    "keyId": null,
    "cryptoProviderFactory": {
      "cryptoProviderCache": {},
      "customCryptoProvider": null,
      "cacheSignatureProviders": true,
      "signatureProviderObjectPoolCacheSize": 32
    }
  }
}
```

**Create Signing Credentials**

```bash
GET /api/security/create-signing-credentials/{securityKey}
```

Response body:

```json
{
  "signingCredential": {
    "algorithm": "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512",
    "digest": null,
    "cryptoProviderFactory": null,
    "key": {
      "keySize": 24,
      "keyId": null,
      "cryptoProviderFactory": {
        "cryptoProviderCache": {},
        "customCryptoProvider": null,
        "cacheSignatureProviders": true,
        "signatureProviderObjectPoolCacheSize": 32
      }
    },
    "kid": null
  }
}
```