redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51MGpUVIIyW3889YdFYsNvKYed1C77WqFqzvEVKuzjUkPnrjqyg8F9EUzpM5tvyyjyTA006xzQslUtBWxGWf21U1L00zl5QqsLa")
    stripe.redirectToCheckout({ sessionId: sessionId });
}