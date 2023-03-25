// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script>
    const roomContainer = document.querySelector('#room-container');
    const nextRoomButton = document.querySelector('#next-room');
    const roomWidth = roomContainer.offsetWidth;

  nextRoomButton.addEventListener('click', () => {
        roomContainer.scrollLeft += roomWidth;
  });
</script>
