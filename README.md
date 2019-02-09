# RedisConnectionDiagnostics

Different Redis host types to diagnose a very specific issue

## Usage

1. Set the `REDISDIAGNOSTICS_CONN` environment variable
2. Run `dotnet run` in all projects

## Redis

You need a Redis installation somewhere, e.g. Heroku offers free Redis hosting.

### Using Docker

```bash
docker pull redis
docker run -p 6379:6379 redis
docker stop (docker ps -q --filter ancestor=redis --format="{{.ID}}")
```

If you have an error like `Error response from daemon: driver failed programming external connectivity on endpoint`, restart docker
