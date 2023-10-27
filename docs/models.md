# Models

## Book
```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"title": "string",
	"description": "string",
	"authors": [
		{
			...
		}
	],
	"genres": [
		{
			...
		}
	],
	"publisher": {
		...
	},
	"publishDate": "0001-01-01T00:00:00Z",
	"isbn": "string",
	"pages": 0,
	"language": "string",
	"image": "string"
}
```

## Author
```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"name": "string",
	"description": "string",
	"books": [
		{
			...
		}
	],
	"birthDate": "0001-01-01T00:00:00Z",
	"image": "string"
}
```

## Genre
```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"name": "string",
	"description": "string",
	"books": [
		{
			...
		}
	]
}
```

## Publisher
```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"name": "string",
	"description": "string",
	"books": [
		{
			...
		}
	]
```

