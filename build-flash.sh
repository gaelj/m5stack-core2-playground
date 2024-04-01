#!/usr/bin/env bash

PG="$HOME/github.com/gaelj/m5stack-core2-playground/M5StackCore2Playground"
NFP="$HOME/.vscode/extensions/nanoframework.vscode-nanoframework-1.0.140/dist/utils/nanoFramework/v1.0/"
SLN="M5StackCore2Playground.sln"
PRJ="Playground1"

pushd "$PG/$PRJ" || return

rm -rf ./**/obj ./**/bin
mono /usr/local/bin/nuget.exe restore ../$SLN
msbuild ../$SLN -p:NanoFrameworkProjectSystemPath="$NFP"

# nanoff --target M5Core2 --serialport /dev/ttyACM0 --update --deploy --image "$PG/$PRJ/bin/Debug/$PRJ.pe"
nanoff --target M5Core2 --serialport /dev/ttyACM0 --deploy          --image "$PG/$PRJ/bin/Debug/$PRJ.pe"

popd || return
