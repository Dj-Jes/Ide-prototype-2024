function drawGraph(currentData, previousData) {
    const canvas = document.getElementById('myChart');
    const ctx = canvas.getContext('2d');

    // Clear canvas
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Define chart dimensions and margins
    const chartWidth = canvas.width - 50;
    const chartHeight = canvas.height - 50;
    const barWidth = chartWidth / (currentData.length + previousData.length);
    const margin = 20;

    // Set colors for current and previous year data
    const currentColor = 'blue';
    const previousColor = 'gray';

    // Loop through each month
    for (let i = 0; i < currentData.length; i++) {
        const month = currentData[i].Month;
        const currentCount = currentData[i].Count;
        const previousCount = previousData.find(d => d.Month === month)?.Count || 0;

        // Calculate bar positions
        const currentBarX = (barWidth * i) + margin;
        const previousBarX = currentBarX + barWidth / 2;

        // Draw bars for current and previous years
        ctx.fillStyle = currentColor;
        ctx.fillRect(currentBarX, chartHeight - currentCount, barWidth / 2, currentCount);
        ctx.fillStyle = previousColor;
        ctx.fillRect(previousBarX, chartHeight - previousCount, barWidth / 2, previousCount);

        // Draw month labels on x-axis
        ctx.font = '12px Arial';
        ctx.fillStyle = 'black';
        ctx.fillText(GetMonthName(month), currentBarX + (barWidth / 4), chartHeight + 15);
    }
}

function GetMonthName(month) {
    const monthNames = ["January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"];
    return monthNames[month - 1];
}