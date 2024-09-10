function generateCalendar() {
    const daysContainer = document.getElementById("days-container");
    const currentDateElement = document.getElementById("current-date");

    // Get current date
    const currentDate = new Date();
    const currentDay = currentDate.getDate();
    const currentMonth = currentDate.toLocaleString('default', { month: 'long' });
    const currentYear = currentDate.getFullYear();
    const currentDayOfWeek = currentDate.getDay();

    // Calculate start of the week (previous Sunday)
    const startOfWeek = new Date(currentDate);
    startOfWeek.setDate(currentDay - currentDayOfWeek);

    // Display current date
    currentDateElement.innerText = `${currentDay} ${currentMonth}`;

    // Clear previous days
    daysContainer.innerHTML = '';

    // Generate days for the current week
    for (let i = 0; i < 7; i++) {
        const dayElement = document.createElement("span");

        // Get the day of the week
        const dayOfWeek = new Date(startOfWeek);
        dayOfWeek.setDate(startOfWeek.getDate() + i);

        const dayNumber = dayOfWeek.getDate();

        // Highlight the current day
        if (dayNumber === currentDay) {
            dayElement.classList.add("selected");
        }

        dayElement.innerText = dayNumber;
        daysContainer.appendChild(dayElement);
    }
}

// Call the function to generate the calendar
generateCalendar();