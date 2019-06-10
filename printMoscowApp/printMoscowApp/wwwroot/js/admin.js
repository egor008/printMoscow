function klikaj(i) {
	var x = document.getElementById(i);
	if (x.className === "show_more") {
		x.className += " responsive";
	} else {
		x.className = "show_more"
	}
}
