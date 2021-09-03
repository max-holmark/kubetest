#!/bin/sh

ROOT="$(cd `dirname $0` && pwd)/.."

docker build -t maxholmark/kubetest $ROOT
docker push maxholmark/kubetest:latest