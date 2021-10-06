az group create
--resource-group vmdemoCLI
--location eastus

az vm create \
--name mylinux \
--resource-group vmdemoCLI\
--admin-username adminuser \
--generate-ssh-keys \
--image ubuntuLTS \
--location eastus

cdh/id_rsa.pub

ssh adminuser@PbIP
Yes
logout
cd /home
ls