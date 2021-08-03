# Blockchain new node creation conflict 
- As we have seen the Bitcoin network contains several miners. 
- It is possible, that the two different miners solve the Proof-of-Work at the same time and thus add their blocks to the last known block in the chain.
- Now, we have two branches after Block 3.
-  Both the branches are valid. So the next mined block may be added in either of the branches.
-  Suppose, the miner adds the newly mined block to Block 104-A, the branch containing Block 104-A will be longer than the branch containing Block 104-B. 
  
# Selfish Mining
- A selfish mining attack, also known as a block withholding attack, describes a malicious attempt to discredit blockchain network integrity. 
- Selfish mining attacks occur when an individual in a mining pool attempts to withhold a successfully validated block from being broadcast to the rest of the mining pool network.