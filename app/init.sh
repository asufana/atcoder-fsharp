#!/bin/sh

# ログイン
acc login
oj login https://beta.atcoder.jp/

# 設定変更
cd $(acc config-dir)
echo '{
    "oj-path": "/home/vscode/.local/bin/oj",
    "default-contest-dirname-format": "{ContestID}",
    "default-task-dirname-format": "{tasklabel}",
    "default-test-dirname-format": "test",
    "default-task-choice": "inquire",
    "default-template": "fsharp",
    "template": "fsharp"
}' > config.json
acc config

# テンプレート整備
mkdir -p fsharp
echo 'printfn "Hello, World!"' > fsharp/main.fsx
echo '{
  "task": {
      "program": [
          "main.fsx"
      ],
      "submit": "main.fsx"
  }
}' > fsharp/template.json

cd /opt/app
