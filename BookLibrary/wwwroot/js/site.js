var counter = 0;

function load() {

  init(counter);
}

function add(n) {
  init(counter += n);
}

function init(n) {
  
  let items;
  items = document.getElementsByClassName('photo');
  if (n > items.length - 1) { counter = 0; }
  if (n < 0) { counter = items.length - 1; }
  for (let i = 0; i < items.length; ++i) {
    items[i].style.display = 'none';
  }
  items[counter].style.display = 'block';
}

function add(n) {
  init(counter += n);
}

        var counter2 = 0;
        /*---- make picture  ----*/

        function add2(n) {
           hide(counter2+=n);
        }

        /*---- make picture  ----*/
        function hide(n) {
            let pict = document.getElementById('theImage');
            if (counter2 > 1) {
                pict.style.display = 'block';
                counter2 = 0;
            }
            else {
                pict.style.display = 'none';
            }

        }
 
    /*---- make picture bigger ----*/

    function biggerImage(id)
    {
      let pict = document.getElementById(id);
      pict.width = 1.2 * pict.width;
    }
    /*---- make picture smaller ----*/

    function smallerImage(id) {
      let pict = document.getElementById(id);
      pict.width = pict.width / 1.2;
    }
    /*---- add resizing buttons and image to placeholder ----*/

    //function loadUrl() {
    //    document.getElementById("theImage").src = document.getElementById("urlSource").value;
    //}
