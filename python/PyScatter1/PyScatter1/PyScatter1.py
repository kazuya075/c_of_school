
import numpy as np
import matplotlib.pyplot as plt
import matplotlib

#matplotlib.use('TkAgg')


print(matplotlib.matplotlib_fname())


# generate data
x = np.random.rand(100)
y = np.random.rand(100)

fig = plt.figure()

ax = fig.add_subplot(1,1,1)

ax.scatter(x,y)

ax.set_title('first scatter plot')
ax.set_xlabel('x')
ax.set_ylabel('y')

fig.show()
plt.show()