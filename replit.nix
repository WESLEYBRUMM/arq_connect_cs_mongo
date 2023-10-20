{ pkgs }: {
	deps = [
   pkgs.nodejs-16_x
   pkgs.mongodb-3_4
		pkgs.jq.bin
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}