
# eCommerce Inveon #2
## What is this project?
This project is the successor to the [last homework](https://github.com/dogacans/eCommerceInveon) I've done in Inveon bootcamp. This adds the functionality of sending emails (extendable with other means of communication such as SMS), and listing what items are bought in what quantity on [Iyzico](https://www.iyzico.com/en) sandbox environment.

## Fixes
1. When given false information such as a bad credit card no in checkout, the website returned the user to "order confirmed" page without checking whether it was a successful payment or not. Fixed this problem by adding a success check to the payment method, and responding isSuccess: false to the API request.
2. When entered a non-existent coupon code, the website errors out every time it tries to load the cart page. This happened because every time a user tried to get the cart page, a request to the coupon API was made, and the database returned a null object if the code was not correct. Then the website tried to get DiscountAmount property of this null object, resulting in a crash. Added a check to see if coupon object was null or not in the coupon API.
3. Fixed an error with the website erroring when a user tries to load the cart page with no items in the cart.


### Libraries/Programs Used
[Fake SMTP server](https://github.com/haravich/fake-smtp-server) for testing e-mail functionality.
    
    docker run -d -p 1025:1025 -p 1080:1080 haravich/fake-smtp-server

[iyzipay API .NET Client](https://github.com/iyzico/iyzipay-dotnet)


## Screenshots of Added Functionality

![Email Sent](https://github.com/dogacans/eCommerceInveon2/blob/main/ExampleEmail.PNG)

![Price Breakdown](https://github.com/dogacans/eCommerceInveon2/blob/main/PriceBreakdown.PNG)


  