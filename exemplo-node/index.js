//Site
//https://www.palcomp3.com/

//Elemento site
//busca_header

//Botão Pesquisar
//submit bt bt_p

const pup = require("puppeteer");

(async () => {
  // Cria browser
  var browser = await puppeteer.launch({ headless: false });

  // Abre nova página
  var page = await browser.newpage();

  // Altera tamanho da pagina
  await page.setViewport({ width: 1336, height: 769 });

  // zera tempo de carregamento
  await page.setDefaultNavgationTimeout(0);

  // chama página
  await page.goto("https://www.palcomp3.com/");

  // preenche a pesquisa
  await page.type("#busca_header", "Padre marcelo", { delay: 100 });

  // seleciona o primeiro da lista
  await page.evaluate(() => {
    document
      .querySelector("#suggest_topo > div:nth-child(1) > ul > li:nth-child(1)")
      .click();
  });

  await page.waitFor(5000);

  var musicas = await page.evaluate(() => {
    return Array.from(
      document
        .getElementsByClassName("lista_musica")[0]
        .getElementsByTagName("li")
    );
  });

  for (var i = 0; musicas.length; i++) {
    await page.evaluate(i => {
      var musicas = document
        .getElementsByClassName("lista_musica")[0]
        .getElementsByTagName("li");

      musicas[i].children.item(2).click();
    }, i);

    await page.waitFor(3000);
  }

  await page.waitFor(60000);

  browser.close();
});
