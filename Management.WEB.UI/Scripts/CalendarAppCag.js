$('#calendar').fullCalendar({
    header: {
        left: 'prev,next today',
        center: 'addEventButton',
        right: 'month,agendaWeek,agendaDay,listWeek'
    },
    defaultDate: '2018-11-16',
    navLinks: true,
    editable: true,
    eventLimit: true,
    events: [{
        title: 'Simple static event',
        start: '2018-11-16',
        description: 'Super cool event'
    },

    ],
    customButtons: {
        addEventButton: {
            text: 'Add new event',
            click: function () {
                var dateStr = prompt('Enter date in YYYY-MM-DD format');
                var date = moment(dateStr);

                if (date.isValid()) {
                    $('#calendar').fullCalendar('renderEvent', {
                        title: 'Dynamic event',
                        start: date,
                        allDay: true
                    });
                } else {
                    alert('Invalid Date');
                }

            }
        }
    },
    dayClick: function (date, jsEvent, view) {
        var date = moment(date);

        if (date.isValid()) {
            $('#calendar').fullCalendar('renderEvent', {
                title: 'Dynamic event from date click',
                start: date,
                allDay: true
            });
        } else {
            alert('Invalid');
        }
    },
});