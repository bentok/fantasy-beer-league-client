import React, { useState } from 'react';

const  App = () => <Headline />;

const Headline = () => {
    const [greeting, setGreeting] = useState(
        'Hello Functional Component!'
    );
    
    const onChange = event => setGreeting(event.target.value);

    return (
        <div>
            <h1>{greeting}</h1>
    
            <input
                type="text"
                value={greeting}
                onChange={onChange}
            />
        </div>
    );
};

export default App;