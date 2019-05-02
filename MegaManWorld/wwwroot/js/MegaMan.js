

$(function () {
	$('#feed').click(function () {
		$.post("/commandpet",
		{
			command: "feed",
		}, function () {
			$("#stats").load("/updatepet");
		});
	});
	//$("#shopList").

  setInterval(function(){
    $("#stats").load("/updatepet");
  }, 100);
});

$(function () {
const app = new PIXI.Application({
    width: 300, height: 300, backgroundColor: 0x1099bb, resolution: window.devicePixelRatio || 1,
});
document.body.appendChild(app.view);

const container = new PIXI.Container();

app.stage.addChild(container);

// Create a new texture
const texture = PIXI.Texture.from('../img/Chill.png');

// Create a 5x5 grid of bunnies
for (let i = 0; i < 1; i++) {
    const bunny = new PIXI.Sprite(texture);
    bunny.anchor.set(0.5);
    bunny.x = (i % 5) * 40;
    bunny.y = Math.floor(i / 5) * 40;
    container.addChild(bunny);
}

// Move container to the center
container.x = app.screen.width / 2;
container.y = app.screen.height / 2;

// Center bunny sprite in local container coordinates
container.pivot.x = container.width / 2;
container.pivot.y = container.height / 2;

// Listen for animate update
app.ticker.add((delta) => {
    // rotate the container!
    // use delta to create frame-independent transform
    container.rotation -= 0.01 * delta;
});
    const anime = require('lib/anime.js');

    anime({
        targets: 'a',
        translateX: 250,
        duration: 3000
    });
 
});
