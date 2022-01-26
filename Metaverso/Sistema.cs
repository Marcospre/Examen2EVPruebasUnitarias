namespace Metaverso
{
    public class Sistema
    {
        public string Saludo(string nombre) => $"Saludos {nombre}!";

        public string metaVerso(int num){
            if(num%3==0 && num%5==0){
                return "Metaverso";
            }else if(num%3==0 && num%5!=0){
                return "Meta";
            }else if(num%3!=0 && num%5==0){
                return "verso";
            }else{
                return $"{num}";
            }
        }

        public string metaArray(int[] num){
            string mensaje=null;
            for(int i=0;i<num.Length;i++){
                mensaje=mensaje+metaVerso(num[i]);
            }
            return mensaje;
        }
    }
}