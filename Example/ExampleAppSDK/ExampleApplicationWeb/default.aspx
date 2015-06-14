<%@ Page Language="C#" %>
<%@ Import Namespace="ExampleApplicationWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Example Web Application</title>
</head>
<style>
        svg, #Canvas {
            width: 100%;
            height: 600px;
        }
</style>
<body>
    <div>
        Select the shape and color:
        
        <select id="Shape">
            <%
                foreach (var shape in Instance.Shapes)
                {
                    %><option value="<%=shape.Path%>"><%=shape.Name%></option><%
                }
            %>
        </select>
        
        <select id="Color">
            <%
                foreach (var color in Instance.Colors)
                {
                    var colorHex = "#" + color.Color.R.ToString("X2") + color.Color.G.ToString("X2") + color.Color.B.ToString("X2");
                    %><option value="<%=colorHex%>"><%=color.Name%></option><%
                }
            %>
        </select>
    </div>
    <div id="Canvas">
        
    </div>
    <script>
        function redraw() {
            var root = document.getElementById('Canvas');
            while (root.hasChildNodes()) {
                root.removeChild(root.lastChild);
            }

            var shapeSelect = document.getElementById("Shape");
            var shape = shapeSelect.options[shapeSelect.selectedIndex].value;

            var colorSelect = document.getElementById("Color");
            var color = colorSelect.options[colorSelect.selectedIndex].value;

            var svg = document.createElementNS('http://www.w3.org/2000/svg', 'svg');
            var path = document.createElementNS('http://www.w3.org/2000/svg', 'path');
            path.setAttribute('d', shape);
            path.setAttribute('stroke', color);
            path.setAttribute('fill', 'None');
            svg.appendChild(path);

            root.appendChild(svg);
        }
        
        // On DOM ready redraw.
        (function () {
            var shapeSelect = document.getElementById("Shape");
            shapeSelect.onchange = function () { redraw(); };
            var colorSelect = document.getElementById("Color");
            colorSelect.onchange = function () { redraw(); };
            redraw();
        })();
    </script>
</body>
</html>
