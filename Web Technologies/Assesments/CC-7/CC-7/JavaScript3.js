< !DOCTYPE html >
    <html>
      <button id="Button">Click Me!</button>
      <script>
        const button = document.getElementById("Button");
        button.addEventListener("click", () => {
            console.log("Button was clicked!");
            alert("Button  clicked Successfully...!");
        });
      </script>
   </html>