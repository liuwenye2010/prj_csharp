
#msbuild MyProject.csproj /target:rebuild /verbosity:diag
csc_buid=csc.exe /out:

all: build run
build:
	$(csc_buid)out.exe *.cs

run:
	./out.exe
	
clean:
	rm -rf *.exe