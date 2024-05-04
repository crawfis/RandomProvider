# RandomProvider
Unity tool to set and create random seeds and control the random process.
# Usage for Random Provider 
1. Create an Empty GameObject
2. Add the RandomProvider component
3. Select the Generate New Seed and use until you have a seed you like.
4. Uncheck the Generate New Seed to use this fixed seed.

# Usage for Random Provider From List
1. Create an Empty GameObject
2. Add the RandomProviderList component
3. Create a folder to hold a scriptable object of the desired random seeds
4. Right-click and select Create->CrawfisSoftware->Create Scriptable: List<int>
5. Drag this scriptable to the RandomProvider field (Fixed Seed list).
6. Click "Generate New Seed" to create new seeds.
7. Select Auto-generate new seed on Play to get the same behavior as RandomProvider.
