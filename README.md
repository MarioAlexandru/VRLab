# VR Lab

<img alt="Game Logo" src="https://github.com/MarioAlexandru/VRLab/blob/main/Assets/logo.png" width="300" height="300">


VRLab este versiunea VR a proiectului nostru, cu cele mai multe experimente, dar care conține și joculețele din versiunile de mobil și de pc.
Proiectul este făcut în Unity și poate fi încărcat direct pe cască și deoarece nu am folosit integrarea de la Oculus, am folosit plugin-urile XR Interaction-Toolkit și OpenXR pentru a avea o varietate mai mare pentru ce tip de cască VR este folosită.

  Modelul și animațiile mâinilor:
https://drive.google.com/file/d/10b39IekUdpBHlcTslZ-BlNRyH5uqPUe1/view?usp=sharing

Proiectul conține 5 scene: meniul, o scenă informativă despre compușii chimici, 3 experimente și un test la final. 
Meniul are și o explicare a controalelor, în scenă informativă am adus din celelalte versiuni modelele 3d ale compușilor chimici, diferență este că de data asta ToolTip-ul este făcut să urmărească camera jucătorului. 

Primul experiment este cel portat pe toate dispotivele, și include testul flăcării la diferiți ioni metalici. 
Al doilea experiment subliniază tipurile de separare ale amestecurilor, și al treilea simulează cristalizarea substanțelor. Pentru a simula dizolvarea și lichidul am folosit shadere.
 Experimentele au instrucțiuni scrise și explicații audio, și informații pe posterele puse prin laborator. 
Volumul audio-ului poate fi controlat din meniul din mână stangă, unde sunt și butoanele din care putem să trecem din scenă în scenă. Acesta este activat doar când jucătorul se uita în palmă. Este câte un glisor separate pentru muzica de fundal (am înregistrat cum am cântat la chitara) și sunetul care sunt explicații pe care le ofer pe parcursul experimentelor.
Înafară de acestea am adăugat și un sistem de notare a jucătorului, salvăm ce notițe sunt făcute într-un fișier json și este câte un fișier diferit pentru fiecare experiment. 

