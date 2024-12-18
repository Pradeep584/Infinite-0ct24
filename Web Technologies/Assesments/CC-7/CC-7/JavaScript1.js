< !DOCTYPE html >
    <html lang="en" xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <meta charset="utf-8" />
            <title>Assessment 7 Questions</title>
        </head>
        <body>

            <h1>Calculator</h1>
            <form>
                1st Number : <input type="text" id="first" /><br>
                    2nd Number: <input type="text" id="second" /><br>
                        <input type="button" onClick="multiplication()" value="multiply" />
                        <input type="button" onClick="division()" value="divide" /> 
</form>
                    <p>
                        The Result is : <br>
                            <span id="sp1"></span>
</p>

                        <h1>odd or even </h1>
                        <div id="sp1"></div>

                        <h1>Button click event</h1>
                        <button id="idbutton">Click me</button>

                        <script>
                            function multiplication()
                            {
                                num1 = document.getElementById("first").value;
                            num2 = document.getElementById("second").value;
                            document.getElementById("sp1").innerHTML = num1 * num2;
        }

                            function division()
                            {
                                num1 = document.getElementById("first").value;
                            num2 = document.getElementById("second").value;
                            document.getElementById("sp1").innerHTML = num1 / num2;
        }


                            let sp1 = '  ';
                            for (let i = 0; i <= 15; i++) {
            if (i % 2 === 0) {
                                sp1 += `${i} is even <br>`;
            } else {
                                sp1 += `${i} is odd <br>`;
            }
        }
                            document.getElementById('sp1').innerHTML = sp1;


                            document.getElementById('entbtn').addEventListener('click', function () {
                                console.log('clicked');
                            alert(' clicked');
        });
                        </script>
 
</body>
</html>
                