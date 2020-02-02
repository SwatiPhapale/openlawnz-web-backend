curl --request POST \
  --url 'https://dev-bwck3zj5.au.auth0.com/oauth/token' \
  --header 'content-type: application/x-www-form-urlencoded' \
  --data grant_type=password \
  --data username='noel@openlaw.nz' \
  --data password=$TEST_PASSWORD \
  --data client_id='x5ZBoQFTdL1Y0E2g3eyZQLshR5hRjpEl'\
  --data audience='https://api.openlaw.nz' \
  --data 'client_id=ivzw5kJjgH7YT63ubD87azWfNMdvnIaH' \
  --data client_secret=YOUR_CLIENT_SECRE$CLIENT_SECRET