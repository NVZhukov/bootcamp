import cv2

face_cascades = cv2.CascadeClassifier(
    cv2.data.haarcascades + "haarcascade_frontalface_default.xml"
)
# img = cv2.imread("D:/c/bootcamp/ExploringOpenCV/face.jpg")
# img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)


# faces = face_cascades.detectMultiScale(img_gray)
# for (x, y, w, h) in faces:
#    cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 0), 2)

# cv2.imshow("Result", img)
# cv2.waitKey(0)
cap = cv2.VideoCapture("D:/c/bootcamp/ExploringOpenCV/video.mkv")
while True:
    _, frame = cap.read()
    img_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascades.detectMultiScale(img_gray)
    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 2)
    cv2.imshow("Result", frame)
    if cv2.waitKey(10) & 0xFF == ord("q"):
        break
