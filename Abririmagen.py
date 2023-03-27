import cv2

#Cargar una imagen a Color
img = cv2.imread('jpg1.jpg', cv2.IMREAD_COLOR)

#Mostrar imagen en ventana
cv2.imshow('Goku', img)

#Esperar indefinidamente hasta que se pulse una tecla
cv2.waitKey(0)

#Destruir todas las ventanas creadas
cv2.destroyAllWindows()