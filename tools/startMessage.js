import colors from 'colors';

let figlet = require('figlet');

/* eslint-disable no-console */
 
figlet('Codebase', {
    font: 'cybermedium'
},function(err, data) {
    if (err) {
        console.log('Something went wrong...');
        console.dir(err);
        return;
    }
    console.log(data.green);
});