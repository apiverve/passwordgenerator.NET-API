Password Generator API
============

Password Generator is a simple tool for generating passwords. It returns the generated password.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Password Generator API](https://apiverve.com/marketplace/api/passwordgenerator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.PasswordGenerator
```

Using the Package Manager:
```
nuget install APIVerve.API.PasswordGenerator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.PasswordGenerator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.PasswordGenerator".
5. Click on the APIVerve.API.PasswordGenerator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the passwordgenerator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Password Generator API documentation is found here: [https://docs.apiverve.com/api/passwordgenerator](https://docs.apiverve.com/api/passwordgenerator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Password Generator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new PasswordGeneratorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new passwordgeneratorQueryOptions {
  count = 10,
  length = 12,
  complexity = "strong"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "length": "30",
    "count": 10,
    "complexity": "strong",
    "passwords": [
      "VvLF-#sN^)X+cwsLG$L/0)DX76Z,d",
      "*fNW3r6PN#a_HE1yTp8Yqliz&=67{",
      "vxVU+(T-2X$FZaGw.1Tu4_paA!WPCf",
      "Ic1YbV)Z@[Wbt=_FMo1*cwQ]j'Wl]",
      "3i,qiyQbe6j{,9%^|OQd'Sh8_L6Xc",
      "f&EH?eSJ8by=w}/4Z{yGvS'j+*wq^h",
      "yW+_j1LBh]Bi#jVtkz';OGIaq+$9@",
      "F-EXq0.S+Hz,HhfZUv&Na^j8sPfL)C",
      "''(y:U0|s.4%$0f[ti_+lta6Zn':Q:",
      "@tz]p11OC2TI?x3x]EjF8q;{fn.=(8"
    ]
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.