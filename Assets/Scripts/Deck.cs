using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{

    [HideInInspector] public int size;

    public Sprite[] Images;
    public List<string> myTexts;
    public CardType[] Types;

    bool _lock;

    public CardSample[] myDeck;

    public int numPlayers;

    void Start()
    {
        size = 115;
    }

    public void CreateCards()
    {
        if (!_lock)
        {
            Imagenes();
            Textos();
            CardTypes();
            CreateDeck();
            _lock = true;

            gameObject.GetComponent<Shuffle>()._lock = true;
        }
    }

    void Update()
    {
        numPlayers = GameObject.Find("GameController").GetComponent<Register>().myPlayers.Count;
    }

    void Imagenes()
    {
        Images = new Sprite[size];
        Images = Resources.LoadAll<Sprite>("");

    }

    void Textos()
    {

        //ABSOLUTA

        myTexts.Add("Actúa tu mejor experiencia sexual sin hablar, solo puedes hacer ademanes y gestos");

        myTexts.Add("Finge tener un orgasmo frente a todos");

        myTexts.Add("Escoge a un jugador para que se termine toda su bebida");

        myTexts.Add("Haz 10 lagartijas");

        myTexts.Add("Narra una anécdota graciosa. De no tener ninguna, quítate una prenda o recibe un castigo");

        myTexts.Add("Me llamo JEFF y estoy aburrido. Inventa una fantasía sexual donde los protagonistas sean los jugadores. Los demás jugadores deben actuarla.");

        myTexts.Add("Terminate tu bebida y escoge a 2 jugadores para que pierdan una prenda o reciban un castigo.");

        myTexts.Add("Dale un trago a la bebida del jugador a tu izquierda.");

        myTexts.Add("Todos beben 2 veces a excepción de ti y otro jugador que escojas.");

        myTexts.Add("Escoge a un jugador, todos le dan un golpe y tú tomas por cada golpe");

        myTexts.Add("Me llamo JEFF y lidia con eso. Bebe 3 veces");

        myTexts.Add("Toma de 2 vasos o botellas a la vez");

        myTexts.Add("Me llamo JEFF, oí que te gusta tomar, así que combina todas las bebidas con la tuya y termínala");

        myTexts.Add("Me llamo JEFF, y lo estás haciendo mal, toma 2 veces");

        myTexts.Add("Dale tu celular a otro jugador, si él encuentra fotos calientes, te quitas una prenda o recibes un castigo");

        myTexts.Add("Elige a un jugador para que sea tu esclavo, puedes darle solo 3 órdenes");

        myTexts.Add("Imita a alguien del grupo, si adivinan quien es, esa persona toma 2 tragos si no adivinan tu tomas 4 tragos");

        myTexts.Add("Todos menos tú, se acaban sus bebidas");

        myTexts.Add("Tomate dos shots, el jugador a tu derecha elegirá la bebida");

        myTexts.Add("Lanza una moneda. Cara, todos beben. Cruz, tomas por cada jugador");

        myTexts.Add("Cada jugador menciona una película en la que Johnny Depp haya actuado, cuando un jugador no pueda decir un título o repita alguno pierde y toma un trago");

        myTexts.Add("Lame la mejilla de " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName);

        myTexts.Add("Cuenta un secreto vergonzoso, de no tener uno tendrás un castigo");

        myTexts.Add("Haz sonidos de animales después de cada trago. Si no lo haces tomas doble (Duración 3 turnos)");

        myTexts.Add("Escoge a la jugadora más bonita, la cual puede hacer una regla nueva");

        myTexts.Add("Tienes prohibido decir NO, si lo haces, le das un trago a tu bebida");

        myTexts.Add("No puedes moverte y debes hablar como robot. El jugador a tu derecha debe ayudarte a beber y moverte (Duración 3 turnos)");

        myTexts.Add("Todos los jugadores te deberán de ignorar, el jugador que no lo haga bebe un trago a su bebida (Duración 2 turnos)");

        myTexts.Add("Actúa como retrasado mental, deberás beber al inicio de cada turno (Duración 3 turnos)");

        myTexts.Add("Escoge a un jugador que será tu ~Escudo~ y deberá de beber por ti 3 veces");

        myTexts.Add("Me llamo JEFF y tu voz me desespera, cada vez que hables toma 3 veces (Duración 2 turnos)");

        myTexts.Add("Inventa una regla");

        myTexts.Add("¡Hoy es tu día! si eres un chico todas las chicas te dan un pico, si eres una chica los chicos te dan un pico");

        myTexts.Add("Adivina el color de la ropa interior de cada jugador, cada uno deberá mostrarlo para confirmar. Si te equivocas tomas");

        myTexts.Add("Me llamo JEFF y haz un baile sensual por 1 minuto");

        myTexts.Add("Escoge una carta y realiza su castigo.)");

        myTexts.Add("Gritas: ~Un animal salvaje~ mientras señalas a un jugador. El último en lanzarle un objeto bebe");

        myTexts.Add("Si has posteado algo en alguna red social en las últimas 24 hrs, dale un trago a tu bebida");

        myTexts.Add("El " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + "toma un shot.");

        myTexts.Add("Tomate una foto con todos los jugadores. Cada uno debe poner cara de algún meme");

        //FUGAZ

        myTexts.Add("¡La GRANADA está activa! Cuando vuelva a salir esta carta, el último en tirarse al suelo recibe un castigo");

        myTexts.Add("El último jugador que haya dicho una pendejada toma 2 tragos");

        //--------->Barajear 5 cartas

        myTexts.Add("Se barajearan las primeras 5 cartas");

        myTexts.Add("Asigna 6 shots, máximo dos por jugador");

        myTexts.Add("El gracioso del grupo toma 3 tragos");

        myTexts.Add("Asigna 2 shots a un jugador");

        myTexts.Add("CASCADA la persona que está leyendo empieza. Cada persona no puede parar de beber hasta que el de la izquierda deje de beber");

        myTexts.Add("Bebe el último que llegó a la fiesta");

        myTexts.Add("Dale una bofetada a otro jugador tan fuerte como quieras, pero solo una vez");

        myTexts.Add("El último jugador en chocar el puño contigo se termina su bebida");

        myTexts.Add("La primera persona que le de un beso en la mejilla al de su izquierda reparte 4 tragos");

        myTexts.Add(GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + " ten la gentileza de terminarte tu bebida y deja que " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + " te de una nalgada en el culo");

        myTexts.Add("Cada jugador dice una serie que está viendo, los que repitan serie beben 3 tragos");

        myTexts.Add("Todos los jugadores con una ~M~ en sus nombres hacen fondo");

        myTexts.Add("Siéntate en las piernas de " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + " hasta que se te indique");

        myTexts.Add("Ya puedes regresar a tu asiento");

        myTexts.Add("O le das un beso a " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + ", o tendrás que quitarte una prenda de vestir");

        myTexts.Add("Tienes que tomar un shot del ombligo de " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName);

        myTexts.Add("QUÉ PREFIERES: Pasar tu vida pobre con el amor de tu vida, o ser multimillonario pero nunca encontrar el amor. Voten todos al mismo tiempo, ¡Los que estén en minoría tendrán que beberse 2 tragos!");

        myTexts.Add("QUÉ PREFIERES: Llevar ropa de verano en invierno o llevar ropa de invierno en verano. Voten todos al mismo tiempo, ¡Los que estén en minoría tendrán que beberse 2 tragos!");

        myTexts.Add("QUÉ PREFIERES: Despertar mañana con un bebé o no poder tenerlo hasta los 65. Voten todos al mismo tiempo, ¡Los que estén en minoría tendrán que beberse 2 tragos!");

        myTexts.Add("QUÉ PREFIERES: Perder 5000 pesos o que la persona que más odies gané 1 millón de pesos. Voten todos al mismo tiempo, ¡Los que estén en minoría tendrán que beberse 2 tragos!");

        myTexts.Add("QUÉ PREFIERES: Ser la persona más inteligente del mundo o la más sexy. Voten todos al mismo tiempo, ¡Los que estén en minoría tendrán que beberse 2 tragos!");

        myTexts.Add("Todos los jugadores que hayan tenido sexo con alguno de los jugadores presente toman un trago");

        myTexts.Add("Todos los jugadores que hayan sido descubiertos mientras se masturbaban toman un trago");

        myTexts.Add("Todos los jugadores hayan fingido un orgasmo beben dos tragos. (Por mentirosos)");


        //PROTECCION

        myTexts.Add("Niega tu castigo y toma otra carta");

        myTexts.Add("Eres inmune a todo durante este turno");

        myTexts.Add("Niega un reto o castigo que no quieras hacer");

        myTexts.Add("Puedes pasar un turno");

        myTexts.Add("Me llamo JEFF, y por este turno eres inmune a todo");

        myTexts.Add("Eres inmune a cartas ABSOLUTAS. (Duración 1 turno)");

        myTexts.Add("Estás protegido contra una carta Fugaz");

        myTexts.Add("Cancela esta carta");

        myTexts.Add("Elimina la carta que está por ser jugada");

        myTexts.Add("Puedes pasar tus tragos a otro jugador");




        //MASACRE

        myTexts.Add("La persona con la ropa interior más sexy deberá terminarse su bebida");

        myTexts.Add("Todos deben mantener una cara seria. El primero en reírse debe terminarse su bebida");

        myTexts.Add("Todos nombran su fetiche. El jugador con el fetiche más raro toma 2 veces");

        myTexts.Add("El jugador más joven debe tomar un trago a su bebida");

        myTexts.Add("A la de tres, todos los jugadores se quitan una prenda y se la arrojan al jugador de enfrente. El último que lo haga bebe");

        myTexts.Add("Todos toman X tragos, donde X es el número de jugadores");

        myTexts.Add("El jugador con el pelo más rubio deberá acabarse su bebida");

        myTexts.Add("El jugador que haya tenido sexo más recientemente debe tomar de su bebida");

        myTexts.Add("Todos los fumadores le dan 2 tragos a su bebida");

        myTexts.Add("Elige a dos personas para que se den un beso");

        myTexts.Add("Posa como una estatua, el último en imitarte bebe 3 tragos");

        myTexts.Add("El jugador HOMBRE con el pelo más largo bebe 3 tragos");

        myTexts.Add("Cada jugador deberá nombrar una enfermedad, el jugador que no pueda continuar sin repetir una o que diga cáncer, recibirá un castigo");

        myTexts.Add("Cada jugador debe imitar a un personaje de película o serie favorita");

        myTexts.Add("Todos deben caminar de forma extraña mientras toman");

        myTexts.Add("Todos los solter@s, toman un trago");

        myTexts.Add("Todos los jugadores que usen o hayan usado anteojos deben beber 4 veces");

        myTexts.Add("Todos los jugadores con barba o bigote deben darle un trago a su bebida");

        myTexts.Add("Cada jugador cuenta el dinero en sus carteras, el jugador con más dinero se salva de tomar 3 tragos");

        myTexts.Add("Todas las mujeres deben beber un trago");

        myTexts.Add("Cada jugador debe decir un piropo, el peor piropo recibe un castigo");

        myTexts.Add("Todos le dan un golpe a " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + ", el cual debe beber por cada golpe");

        myTexts.Add("Cada jugador toma un trago por el número de hermanos que tiene");

        myTexts.Add("El jugador que haya tenido el “faje” más reciente, se quita una prenda o recibe un castigo");

        myTexts.Add("El jugador con los pantalones más ajustados debe quitarse una prenda o recibir un castigo");

        myTexts.Add("Me llamo JEFF y los odio a todos, todos se acaban su bebida");

        myTexts.Add("Todos juegan 2 rondas de ~Verdad o Reto~. No se puede repetir la misma opción 2 veces seguidas");

        myTexts.Add("Cada jugador dice un dato interesante, el menos interesante toma un trago");

        myTexts.Add("Cada jugador tiene que cantar una canción, si alguien la adivina deberás tomar un trago, de lo contrario todos toman un trago");

        myTexts.Add("El jugador más viejo toma 3 veces");

        //VERSUS

        myTexts.Add("Reta a " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + "a jugar manotazos, el que pierda 2 veces recibe un castigo");

        myTexts.Add("Tú vs " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + ", escogan a otro jugador, cada pareja tiene que quitarle una prenda de ropa con la boca a su compañero, los perdedores reciben un castigo");

        myTexts.Add("Escoge a un jugador para que te de un ¬arrimón~, el primero en quitarse antes de 30 segundos debe acabarse su bebida");

        myTexts.Add("Escoge a un compañero y a otra pareja, permanezcan un minuto cara a cara, el primer equipo en reírse pierde y tienen que quitarse una prenda o recibir un castigo");

        myTexts.Add("Reta a " + GameObject.Find("GameController").GetComponent<Register>().myPlayers[Random.Range(0, numPlayers)].mName + " a jugar semana inglesa contigo");

        myTexts.Add("El último en ponerse de pie bebe 3 tragos");

        myTexts.Add("El primero en parpadear toma 2 tragos");

        myTexts.Add("Reta a otro jugador a beber de cabeza, el primero en terminarse su bebida gana. El perdedor se quita una prenda o recibe un castigo");

        myTexts.Add("Escoge a un compañero y otra pareja, la pareja que haga más posiciones de Kama Sutra en 1 minuto gana. Los perdedores reciben 2 órdenes de los ganadores");

        myTexts.Add("3 rodas de volados: por cada que pierdas te quitas una prenda, por cada que ganes los demás jugadores pierden una prenda");

    }

    void CardTypes()
    {
        Types = new CardType[size];

        for (int i = 0; i < size; i++)
        {
            if (i >= 0 && i <= 39)
            {
                Types[i] = CardType.ABSOLUTA;
            }

            if (i >= 40 && i <= 69)
            {
                Types[i] = CardType.FUGAZ;
            }

            if (i >= 70 && i <= 80)
            {
                Types[i] = CardType.PROTECCION;
            }

            if (i >= 81 && i <= 111)
            {
                Types[i] = CardType.MASACRE;
            }

            if (i >= 112)
            {
                Types[i] = CardType.VERSUS;
            }

        }
    }

    void CreateDeck()
    {
        myDeck = new CardSample[size];

        for (int i = 0; i < size; i++)
        {

            myDeck[i] = new CardSample(Images[i], myTexts[i], Types[i]);


        }
    }
}




