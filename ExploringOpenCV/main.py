import cv2

img = cv2.imread("D:/c/bootcamp/ExploringOpenCV/test.jpeg")
image = cv2.imread("D:/c/bootcamp/ExploringOpenCV/img1.jpg")
# image = cv2.resize(image, (400, 400))
print(image.shape)
cv2.imshow("Result", image)
cv2.waitKey(0)
