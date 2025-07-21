document.addEventListener('DOMContentLoaded', () => {
    const songList = document.getElementById('song-list');
    const audioPlayer = document.getElementById('audio-player');

    if (songList) {
        songList.addEventListener('click', (event) => {
            const songRow = event.target.closest('.song-row');

            if (songRow) {
                const src = songRow.getAttribute('data-audio');
                audioPlayer.src = src;
                audioPlayer.play();
            }
        });
    }
});

function renderBeatinformation(beats) {
    let beatNumber = 1;
    beats.forEach(beat => {
        createBeatDiv(beat, beatNumber);
        beatNumber = beatNumber + 1;
    });
}

function createBeatDiv(beat, beatnumber) {
    const songList = document.getElementById('song-list');

    const row = document.createElement('div');
    row.className = 'song-row';
    row.setAttribute('data-audio', beat.musicPath);

    row.innerHTML = `
        <div class="song-index">${beatnumber}</div>
        <div class="song-cover"><img src="${beat.cover}" alt="Cover"></div>
        <div class="song-info">
            <div class="song-title">${beat.name}</div>
            <div class="song-artist">${beat.artist}</div>
        </div>
        <div class="song-album">${beat.album}</div>
        <div class="song-added">${beat.added}</div>
        <div class="song-duration">${beat.duration}</div>
    `;

    songList.appendChild(row);
}
function GetBeatData() {
    $.ajax({
        type: "GET",
        url: "/music/GetBeats",
        dataType: "json",
        success: function (Data) {
            allBeatsData = Data;
            renderBeatinformation(allBeatsData);
        },
        error: function (req, status, error) {
            console.log("Status: " + status);
            console.log("Error: " + error);
            console.log("Response: " + req.responseText);
        }
    });
}

window.onload = function () {
    GetBeatData();
}