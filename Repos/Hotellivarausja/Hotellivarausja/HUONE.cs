using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellivarausja
{
    /*
     * Tämän luokan avulla hallitsemme huoneita
     * Tee kuitenkin huonekategoriaa varten oma taulukkonsa
     * phpMyAdminin avulla, jossa on seuraavat kentät
     * - KategoriaID (Primary key)
     * - Huone tyyppi (Yhden hengen, Kahden hengen, Perhehuone, Sviitti)
     * - Hinta (120, 90, 150, 300)
     * 
     *      CREATE TABLE `hotelli`.`huonekategoria` 
     *      ( `kategoriaId` INT NOT NULL AUTO_INCREMENT , `Huonetyyppi` VARCHAR(15) NOT NULL , `Hinta` DECIMAL NOT NULL , PRIMARY KEY (`kategoriaId`))
     *      
     *      INSERT INTO huonekategoria (Huonetyyppi, Hinta) VALUES 
     *      ("Yhden hengen", 120.00), ("Kahden hengen", 90.00), ("Perhe", 150.00), ("Sviitti", 300.00)
     *      
     * Ja Huoneet-taulukko, jossa on seuraavat kentät
     * - Huoneen numero (kerroksittain)
     * - Huoneen tyyppi (valitaan huonekategoriasta)
     * 
     *      CREATE TABLE huoneet (
     *      Huoneen_numero INTEGER PRIMARY KEY,
     *      Huonetyyppi INTEGER,
     *      FOREIGN KEY(Huonetyyppi) REFERENCES huonekategoria(kategoriaId));
     */
    class HUONE
    {
    }
}
