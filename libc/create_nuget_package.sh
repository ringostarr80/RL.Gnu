#!/bin/sh

set -e

NUSPEC_FILE=RL.Gnu.libc.nuspec
LINUX_NUSPEC_FILE=RL.Gnu.libc.linux.nuspec
SED_REGEX='s/\(="\)\([^"]*\)\\\([^"]*\)/\1\2\/\3/g'
cat ${NUSPEC_FILE} | sed -e ${SED_REGEX} | sed -e ${SED_REGEX} | sed -e ${SED_REGEX} > ${LINUX_NUSPEC_FILE}

dotnet pack --configuration=Release

rm ${LINUX_NUSPEC_FILE}

exit
