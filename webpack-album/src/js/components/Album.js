export default function Album(albums) {
    return `

<section id="albumgrid">    
<ul> 
    ${albums
      .map(album => {
        return `
             <li id="album">
                <img src=${album.image}></img>
                <h3>${album.title}</h3>
                <h5>Label: ${album.label}</h5>  
             </li>
        `;
      })
      .join("")}
 </ul>
 </section>

<section class='add-album'>
    <input class='add-album_albumTitle' type='text' placeholder='Add A New Album!'>
    <select class= 'add-album_artist' name="Artist">
    <option value="1">Kid Cudi</option>
    <option value="2">Imagine Dragons</option>
    <option value="3">Pink Floyd</option>
    <option value="4">Alicia Keys</option>
    </select>
    <input class='add-album_albumLabel' type='text' placeholder='Add A Record Label!'>
    <button class='add-album_submit'>Submit</button>
</section>
    `;
}