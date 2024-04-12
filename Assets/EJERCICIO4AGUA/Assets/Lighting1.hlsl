void GetMainLight_float(out float3 Direction, out float3 Color)//Tenemos 2 salidas, la dirección y el color
{
	Direction = float3(1,1,-1);
	Color = 1;
	//float3 vector de 3 dimensiones donde cada uno es un float
	#ifdef UNIVERSAL_LIGHTING_INCLUDED //Mientras exista esta librería
	Light l = GetMainLight();
	Direction = l.direction;
	Color = l.color;
	#endif //Ejecuta este código
}

//Un float ocupa 4 bytes o 32 bits
//half ocupa 2 bytes o 16 bits
void Add_float(float A, float B, out float Result)
{
	//Inicializamos los valores A, B y Result
	Result = A + B;

} 

#endif