$(function () {
    //initial gridstack
    var options = {
        //cell_height: 80,
        vertical_margin: 10
    };
    $('#gs-container').gridstack(options);

});
//update widget
function fnUpdateWidget(classOrId, findClassOrId) {
    var items = $(classOrId).find(findClassOrId);
    var widgetObject = [];
    $.each(items, function (index, value) {
        var item = {
            gsX: $(value).attr("data-gs-x"),
            gsY: $(value).attr("data-gs-y"),
            gsW: $(value).attr("data-gs-width"),
            gsH: $(value).attr("data-gs-height")
        }
        widgetObject.push(item);
    });
    console.log(widgetObject);
};

//chart.js
var ctx = document.getElementById('myChart').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['M', 'T', 'W', 'T', 'F', 'S', 'S'],
        datasets: [{
            label: 'apples',
            data: [12, 19, 3, 17, 6, 3, 7],
            backgroundColor: "rgba(153,255,51,0.6)"
        }, {
            label: 'oranges',
            data: [2, 29, 5, 5, 2, 3, 10],
            backgroundColor: "rgba(255,153,0,0.6)"
        }]
    }
});