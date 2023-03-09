mergeInto(LibraryManager.library, {
    
    AgRuAuth: async function () {
        const sdk = new AgRuSdk({
            
        });

        const [data, error] = await sdk.authorize();
    },
    
    ImJohnny: async function () {
        const sdk = new AgRuSdk({
            
        });
        
        var returnStr = await sdk.sayHello();
        var bufferSize = lengthBytesUTF8(returnStr) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;
    }
});
