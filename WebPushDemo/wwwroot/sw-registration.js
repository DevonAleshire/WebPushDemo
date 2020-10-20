if ("serviceWorker" in navigator) {
    console.log('Service worker registered');
    navigator.serviceWorker.register("/sw.js");
}