import re

print(len([False for m in [re.match("(\\d+)-(\\d+) (\\S): ([^\\n]+)", l) for l in Input.splitlines()] if (list(m.group(4))[int(m.group(1)) - 1] == m.group(3)) != (list(m.group(4))[int(m.group(2)) - 1] == m.group(3))]))